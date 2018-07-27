$(document).ready(function () {

    // when page loads, check if theres anything in the cart and update the display
    loadCookies();


    function loadCookies() {
        // check if a cookie exists
        if (document.cookie.length != 0) {
            // separate the value from the key pair
            var myCookieArray = document.cookie.split("=");
            // separate the productIds
            var cookieValuesArray = myCookieArray[1].split("_");
            // count the productIds and display the result
            document.getElementById("numberofitems").innerHTML = cookieValuesArray.length;
        }
    };


});