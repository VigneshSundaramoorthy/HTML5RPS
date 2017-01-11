function GetDateTime() {
    var date = new Date();
    return "Date: " + date.getDate() + "-" + (date.getMonth() + 1) + "-" + date.getFullYear()
            + ", Time: " + date.getHours() + ":" + date.getMinutes() + ":" + date.getSeconds();
}