window.onload = (event) => {
    onStart();
    function onStart(){
        var range =document.querySelector("#inputRange");
        var value = document.querySelector(".value");
        value.innerHTML="1";
        range.addEventListener("input",changeValue)
        function changeValue(){
            value.innerHTML = range.value;
        }
    }
    
  };