function clickitem(id) {
    nowID = id;
    var crt = document.getElementById('itml_' + id);
    var prv = document.getElementById('itml_' + oldid);
    crt.style.backgroundColor = '#FCE6C9';
    if(oldid != id) prv.style.backgroundColor = '#fcf9f7';
    oldid = id;
    //window.external.Edit(id);
}

var nowID = 0;

function startEdit(id) {
    var tgt = document.getElementById('ori_' + id);
    if(tgt != null) {
        tgt.scrollIntoView(true);
        clickitem(id);
        nowID = id;
    }
    window.external.Edit(id);
}

document.onkeydown = function (ev) {
    var e = ev || window.event;
    if(e) {
        if(e.keyCode == 13) {//Enter
            startEdit(nowID);
        }
        if(e.keyCode == 38 || e.keyCode == 69) {//Up or e
            if(nowID != 0) nowID --;
            var tgt = document.getElementById('ori_' + nowID);
            if(tgt == null) {
                nowID ++;
                return;
            }
            clickitem(nowID);
            tgt.scrollIntoView(true);
        }
        if(e.keyCode == 40 || e.keyCode == 68) {//Down or d
            nowID++;
            var tgt = document.getElementById('ori_' + nowID);
            if(tgt == null) {
                nowID --;
                return;
            }
            clickitem(nowID);
            tgt.scrollIntoView(true);
        }
        if(e.keyCode == 79) {
            previewer('ori_' + nowID,'prv_' + nowID);
        }
        if(e.keyCode == 84) {
            previewer('trs_' + nowID,'prv_' + nowID);
        }
    }
}

String.prototype.replaceAll = function(s1,s2){ 
    return this.replace(new RegExp(s1,"gm"),s2); 
}

function stringEncoder(str) {
    if(str == null) return '';
    var lcf = false;
    var ans = '';
    for(var i = 0; i < str.length; ++i) {
        var c = str.charAt(i);
        if(c == '#') {
            c = str.charAt(i + 1);
            if(c == '0' || c == '1') {
                i ++;
                ans += '#' + c;
                lcf = true;
                continue;
            }
            if(c == '#') {
                i ++;
                ans += '##';
                lcf = false;
            }
        }

        if(c == '{') {
            if(str.charAt(i + 1) == '{') {
                ans += '{';
                i+=2;
                continue;
            }

            ++i;
            c = str.substring(i, i + 2);
            i += 3;//skip to ':'
            if(c == '%s') {
                i--;//there is no ':'
                ans += '%s';
                continue;
            }
            if(c == '%d') {
                i--;
                ans += '%d';
                continue;
            }
            if(c == 'RG') {
                ans += 'RG' + str.substring(i, i + 6);
                i += 6;
            }
            else {
                ans += c + str.substring(i, i + 2);
                i += 2;
            }
            continue;
        }

        if(c == '{') {
            ans += '{{}';
            continue;
        }

        if (c == '\r') {
            ++i;
            if (str.charAt(i) == '\n') {//for CR
                ans += 'CR';
                lcf = false;
                continue;
            }
            ans += '\r';
        }

        
        if(!lcf) {
            if((c.charCodeAt(0) >= 'A'.charCodeAt(0) && c.charCodeAt(0) <= 'Z'.charCodeAt(0))
                || (c.charCodeAt(0) >= 'a'.charCodeAt(0) && c.charCodeAt(0) <= 'z'.charCodeAt(0))
                || (c.charCodeAt(0) >= '0'.charCodeAt(0) && c.charCodeAt(0) <= '9'.charCodeAt(0))
                || (c.charCodeAt(0) >= '!'.charCodeAt(0) && c.charCodeAt(0) <= '?'.charCodeAt(0))) c = String.fromCharCode(c.charCodeAt(0) + 65248);
            if(c == ' ') c = '　';
        }

        ans += c;
    }
    return ans;
}

function stringDecoder(str) {
    if(str == null) return '';
    var lcf = false;
    var ans = '';
    for(var i = 0; i < str.length; ++i) {
        var c = str.charAt(i);
        if(c == '#') {
            c = str.charAt(i + 1);
            if(c == '0' || c == '1') {
                i ++;
                ans += '#' + c;
                lcf = true;
                continue;
            }
            if(c == '#') {
                i ++;
                ans += '##';
                lcf = false;
            }
        }

        if(c == '%') {
            c = str.charAt(i + 1);
            if(c == 's') {//for %s
                i++;
                ans += '{%s}';
                lcf = false;
                continue;
            }
            if(c == 'd') {//for %d
                i++;
                ans += '{%d}';
                lcf = false;
                continue;
            }
        }

        if(c == 'C') {
            c = str.charAt(i + 1);
            if(c == 'R') {//for CR
                i++;
                ans += '\r\n';
                lcf = false;
                continue;
            }
            if(c == 'L') {//for CLXX
                i++;
                ans += '{CL:';
                ans += str.substring(i, i + 2);
                i += 1;
                ans += '}';
                continue;
            }
            ans += 'C';
            continue;
        }

        if(c == 'I')//for IMXX
        {
            c = str.charAt(i + 1);
            if(c == 'M') {
                i+=2;
                ans += '{IM:';
                ans += str.substring(i, i + 2);
                i += 1;
                ans += "}";
                continue;
            }
            ans += 'I';
            continue;
        }

        if(c == 'S') {
            c = str.charAt(i + 1);
            if(c == 'P') {
                i+=2;
                ans += '{SP:';
                ans += str.substring(i, i + 2);
                i += 1;
                ans += "}";
                continue;
            }
            ans += 'S';
            continue;
        }

        if(c == 'R') {
            c = str.charAt(i + 1);
            if(c == 'G') {
                i+=2;
                ans += '{RG:';
                ans += str.substring(i, i + 6);
                i += 5;
                ans += "}";
                continue;
            }
            c+='R';
            continue;
        }

        if(c == '{') {
            ans += '{{}';
            continue;
        }

        if(isEng) {
            if((c.charCodeAt(0) >= 'Ａ'.charCodeAt(0) && c.charCodeAt(0) <= 'Ｚ'.charCodeAt(0))
                || (c.charCodeAt(0) >= 'ａ'.charCodeAt(0) && c.charCodeAt(0) <= 'ｚ'.charCodeAt(0))
                || (c.charCodeAt(0) >= '０'.charCodeAt(0) && c.charCodeAt(0) <= '９'.charCodeAt(0))
                || (c.charCodeAt(0) >= '！'.charCodeAt(0) && c.charCodeAt(0) <= '？'.charCodeAt(0))) c = String.fromCharCode(c.charCodeAt(0) - 65248);
            if(c == '　') c = ' ';
        }

        ans += c;
    }
    return ans;
}

var oldid = 0;
