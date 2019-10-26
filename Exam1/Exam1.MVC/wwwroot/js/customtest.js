  
    function getToken() {
        $.ajax({
            type: 'POST',
            url: 'http://test-jwt.hazir.net/users/authenticate',
            data: '{username:"test", password:"123456"}',
            contentType: 'application/json',
            success: function (resultData) {
                console.log(resultData.token);
                window.Token = resultData.token;
                $("#Token").val(resultData.token);
            },
            error: function (resultData) {
                console.log(resultData);
            }
        });
    }

    function getValues() {
        $.ajax({
            type: 'GET',
            url: 'http://test-jwt.hazir.net/users',

            beforeSend: function (xhr) {
                xhr.setRequestHeader("Authorization", "Bearer " + window.Token);// values alanına ulaşırken token ı eklemiş oldukç.
            },
            data: {},
            success: function (data) {
                $.each(data, function (i) {
                    console.log(data[i]);
                })

                for (var i = 0; i < data.length; i++) {
                    postValues(data[i]);
                }
            },

            error: function (data) {
                console.log(data);
            }
        });
    }


    function postValues(data) {
        $.ajax({
            type: 'POST',
            url: 'http://localhost:51342/api/user',
            beforeSend: function (xhr) {
                xhr.setRequestHeader("Authorization", "Bearer " + window.Token);// values alanına ulaşırken token ı eklemiş oldukç.
            },
            contentType: 'application/json',
            dataType: 'json',
            data: JSON.stringify(data),
            success: function (data) {
                console.log(data);
            },
            error: function (data) {
                console.log(data);
            }
        });
    }


