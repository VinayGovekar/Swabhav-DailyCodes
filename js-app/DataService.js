var DataService = function(){
    var service = {}
    
    function buildUrl(no){
        return "http://numbersapi.com/"+no+"?json";
    }

    service.getViaFetch=function(no){
        var promise = fetch(buildUrl(no)).then(response=>response.json());
        return promise;
    }

    service.getViaXHR = function(no,fnResult){
        var xhr = new XMLHttpRequest();
        xhr.addEventListener("load",()=>{
            fnResult(JSON.parse(xhr.response));
        });
        xhr.open("GET",buildUrl(no));
        xhr.send();
    }
    return service;
}();