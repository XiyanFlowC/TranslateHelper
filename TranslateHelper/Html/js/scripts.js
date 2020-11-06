function clickitem(id) {
    var crt = document.getElementById('itml_' + id);
    var prv = document.getElementById('itml_' + oldid);
    crt.style.backgroundColor = '#FCE6C9';
    if(oldid != id) prv.style.backgroundColor = '#fcf9f7';
    oldid = id;
    //window.external.Edit(id);
}

function startEdit(id) {
    window.external.Edit(id);
}

var oldid = 0;
