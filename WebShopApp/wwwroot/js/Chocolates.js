$(document).ready(function () {

    // when page loads, check if theres anything in the cart and update the display
    //loadCookies();

    
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

    function saveCookies(productId) {
        // check if cookie exists 
        if (document.cookie.length == 0) {
            // if not create it
            document.cookie = "products=" + productId + "; path=/";
        }
        else {
            // otherwise append a "," then the productId 
            var cookieArray = document.cookie.split(";");
            // try deleting the cookie and recreating in hope asp.net reads new cookie, not just the original before append
            //document.cookie = "products=; expires=Thu, 01 Jan 1970 00:00:01 GMT; path=/";
            document.cookie = cookieArray[0] + "_" + productId + "; path=/";
        
        }

        // update cart display
        loadCookies();
    };

    $(".addtocartbtn").on("click", function () {
        saveCookies($(this).val());
    })

});