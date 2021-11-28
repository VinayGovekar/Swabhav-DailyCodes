window.onload = (event) => {
    
    var ballCount=1;
    var secondContainer = document.querySelector(".secondContainer");
    secondContainer.style.display = "none";
    var range =document.querySelector("#inputRange");
    var value = document.querySelector(".value");
    value.innerHTML="1";
    range.addEventListener("input",changeValue)
    function changeValue(){
        value.innerHTML = range.value;
    }
    
    var firstBox = document.querySelector(".firstContainer");
    function onStart(){

    }
  };