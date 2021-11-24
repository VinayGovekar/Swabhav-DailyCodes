
window.onload=function(){
    var addButton = document.querySelector("#addButton");
    console.log(addButton);
    var toDoItems = [];
    
    function addItems()
    {
        var itemName = document.querySelector(".itemName");
        toDoItems.push(itemName.value);
        var displayBox = document.querySelector(".displayBox");
        var displayString= "<ol>";
        for(let i=0;i<toDoItems.length;i++){
            displayString=displayString+"<li>"+toDoItems[i]+"</li>";
        }
        displayString +="</ol>";
        displayBox.innerHTML = displayString;
    }
    addButton.addEventListener("click",addItems);
}
