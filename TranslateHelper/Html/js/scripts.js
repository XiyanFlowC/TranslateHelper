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

function stringEncoder(str) {
    return str.replace("\r\n", "CR");
}

function stringDecoder(str) {
    return str.replace("CR", "\r\n");
}

var oldid = 0;
