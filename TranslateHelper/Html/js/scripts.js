function clickitem(id) {
    var ori = document.getElementById('ori_' + id);
    var trs = document.getElementById('trs_' + id);
    ori.style.backgroundColor = trs.style.backgroundColor = '#FCE6C9';
    if (oldid != id)
        document.getElementById('ori_' + oldid).style.backgroundColor
            = document.getElementById('trs_' + id).style.backgroundColor
            = '#FAF0E6';
    oldid = id;
    //window.external.Edit(id);
}

function startEdit(id) {
    window.external.Edit(id);
}

var oldid;
