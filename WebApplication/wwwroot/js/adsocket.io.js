var wsUri = "wss://localhost:44337/admin";

function init() {
    websocket = new WebSocket(wsUri);
    websocket.onopen = function (evt) {
        onOpen(evt);
    };
    websocket.onclose = function (evt) {
        onClose(evt);
    };
    websocket.onmessage = function (evt) {
        onMessage(evt);
    };
    websocket.onerror = function (evt) {
        onError(evt);
    };
}

function onOpen(evt) {
    writeToScreen("CONNECTED");
    // doSend("WebSocket rocks");
}

function onClose(evt) {
    writeToScreen("DISCONNECTED");
}

function onMessage(evt) {
    writeToScreen('onMessage');
    console.log(evt);
    changeOrder();
    if (evt.data.success && evt.data.key == "invoice") {
        changeOrder();
    }
    //websocket.close();
}

function onError(evt) {
    writeToScreen('onError');
    onOpen();
}

function doSend(message) {
    writeToScreen("SENT: " + message);
    websocket.send(message);
}

function writeToScreen(message) {
    console.log(message);
}

window.addEventListener("load", init, false);