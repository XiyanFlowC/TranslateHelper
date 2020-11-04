function previewer(srcId, dstId) {
    var s_inner = document.getElementById(srcId).textContent;
    var i = 0;
    var s = '';
    var spanc = 0;
    var noc = false;
    while (i < s_inner.length) {
        var c = s_inner.charAt(i++);
        if (c == '#') {
            if (s_inner.charAt(i) == '0') {
                ++i;
                s += '<span style="font-family:Georgia">';
                ++spanc;
                noc = true;
            }
            if (s_inner.charAt(i) == '#') {
                ++i;
                --spanc;
                s += '</span>';
                noc = false;
            }
            if (s_inner.charAt(i) == '1') {
                ++i;
                ++spanc;
                s += '<span style="font-family:Hymmnos">';
                noc = true;
            }
        }
        if (!noc) {
            if (c == 'I') {
                if (s_inner.charAt(i) == 'M') {//for IMXX
                    c = s_inner.charAt(++i);
                    c += s_inner.charAt(++i);
                    ++i;
                    s += '<img src="/assets/preview/im_' + c + '.webp" />';
                    continue;
                }
            }
            if (c == 'S') {
                if (s_inner.charAt(i) == 'P') {//for SPXX
                    c = s_inner.charAt(++i);
                    c += s_inner.charAt(++i);
                    ++i;
                    s += '<img src="/assets/preview/sp_' + c + '.webp" />';
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
            } if (c == 'C') {
                if (s_inner.charAt(i) == 'R') {//for CR
                    ++i;
                    s += '<br />';
                    continue;
                }
            }
        }
        s += c;
    }

    while (spanc > 0) {
        --spanc;
        s += '</span>';
    }
    document.getElementById(dstId).innerHTML = s;
}