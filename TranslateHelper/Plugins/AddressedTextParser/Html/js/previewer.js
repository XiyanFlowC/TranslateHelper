//coded by xi_yan
//for localization of Ar tonelico: Melody of Elemia
function previewer(srcId, dstId) {
    var s_inner = document.getElementById(srcId).innerHTML;
    document
    var i = 0;
    var s = '';
    var spanc = 0;
    var noc = false;//avoid half-shape charas be recognized as ctrseq
    while (i < s_inner.length) {
        var c = s_inner.charAt(i++);
        if (c == '#') {
            if (s_inner.charAt(i) == '0') {
                ++i;
                s += '<span style="font-family:Hymmnos">';
                ++spanc;
                //noc = true;//seems that the ctrseq is higher then anything
                continue;
            }
            if (s_inner.charAt(i) == '#') {
                ++i;
                --spanc;
                s += '</span>';
                //noc = false;
                continue;
            }
            if (s_inner.charAt(i) == '1') {
                ++i;
                ++spanc;
                s += '<span style="font-family:Georgia">';
                //noc = true;
                continue;
            }
        }
        if (!noc) {
            if (c == 'I') {
                if (s_inner.charAt(i) == 'M') {//for IMXX
                    c = s_inner.charAt(++i);
                    c += s_inner.charAt(++i);
                    ++i;
                    s += '<img src="' + dirroot + '/img/im' + c + '.png" height=22px/>';
                    continue;
                }
            }
            if (c == 'S') {
                if (s_inner.charAt(i) == 'P') {//for SPXX(Ukn)
                    c = s_inner.charAt(++i);
                    c += s_inner.charAt(++i);
                    ++i;
                    //s += '<img src="' + dirroot + '/img/sp' + c + '.png" height=22px/>';
                    continue;
                }
            }
            if (c == 'C') {
                if (s_inner.charAt(i) == 'L') {//for CLXX
                    c = s_inner.charAt(++i);
                    c += s_inner.charAt(++i);
                    ++i;
                    spanc++;
                    switch (c) {
                        case "BK":
                            s += '<span style="color:black">';
                            break;
                        case "RE":
                            s += '<span style="color:red">';
                            break;
                        case "BL":
                            s += '<span style="color:blue">';
                            break;
                        case "GR":
                            s += '<span style="color:green">';
                            break;
                        case "R1":
                            s += '<span style="color:maroon">';
                            break;
                        case "B1":
                            s += '<span style="color:navy">';
                            break;
                        case "P1":
                            s += '<span style="color:purple">';
                            break;
                        case "NR":
                            s += '<span style="color:white">';
                            break;
                        default:
                            break;
                    }
                    //s += '<img src="' + dirroot + '/img/sp' + c + '.png" height=22px/>';
                    continue;
                }
            }
            if (c == 'R') {
                if (s_inner.charAt(i) == 'G') {
                    c = s_inner.charAt(++i);
                    c += s_inner.charAt(++i);
                    c += s_inner.charAt(++i);
                    c += s_inner.charAt(++i);
                    c += s_inner.charAt(++i);
                    c += s_inner.charAt(++i);
                    ++i;

                    s += '<span style="color:#' + c + '">';
                    spanc++;
                    continue;
                }
            }
            if (c == 'S') {
                if (s_inner.charAt(i) == 'C') {//for SCXX
                    c = s_inner.charAt(++i);
                    c += s_inner.charAt(++i);
                    ++i;
                    s += '<span style="font-size:' + c + 'px">';
                    spanc++;
                    continue;
                }
            }
            if (c == 'C') {
                if (s_inner.charAt(i) == 'R') {//for CR
                    ++i;
                    s += '<br />';
                    continue;
                }
            }
        }
        if(isEng)
        {
            if((c.charCodeAt(0) >= 'Ａ'.charCodeAt(0) && c.charCodeAt(0) <= 'Ｚ'.charCodeAt(0))
            || (c.charCodeAt(0) >= 'ａ'.charCodeAt(0) && c.charCodeAt(0) <= 'ｚ'.charCodeAt(0))
            || (c.charCodeAt(0) >= '０'.charCodeAt(0) && c.charCodeAt(0) <= '９'.charCodeAt(0))
            || (c.charCodeAt(0) >= '！'.charCodeAt(0) && c.charCodeAt(0) <= '？'.charCodeAt(0))) c = String.fromCharCode(c.charCodeAt(0) - 65248);
            if(c == '　') c = ' ';
        }
        s += c;
    }

    while (spanc > 0) {
        --spanc;
        s += '</span>';
    }
    document.getElementById(dstId).innerHTML = s;
}

var isEng = false;