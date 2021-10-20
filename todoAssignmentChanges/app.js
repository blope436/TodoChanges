const todoList = [];

const get = (elements) => elements.map((element) => document.getElementById(element));

const [pendingList, completedList, addForm, enterText] = get
(["pendingList","completedList", "addForm", "enterText"]);

const newList = [{
    element: pendingList,
    status: "pending"
},
{
    element: completedList,
    status: "completed"
}

];

const cssClasses = {
    pending:"bg-purple-300 w-full text-center text-red-800 rounded py-4 border-2 border-purple-500 transition transform ease-in-out duration-200 hover:bg-purple-200 hover:text-black hover:scale-100 hover:-rotate-2 cursor-pointer",

    completed:"bg-green-200 w-full text-center text-blue-800 rounded py-4 border-2 border-green-500 transition transform ease-in-out duration-200 hover:bg-green-100 hover:text-black hover:scale-100 hover:-rotate-2 cursor-pointer"
};

const updateToDo = () => {

    newList.forEach((list) => {
    const filteredTodo = todoList.filter((todo) => todo.status === list.status);

    list.element.innerHTML = "";

    filteredTodo.forEach((todo)=>{const item = document.createElement("li")
    item.className = cssClasses[list.status];
    item.innerText = todo.text
    item.id = todo.id;
    list.element.appendChild(item);
});
});
    
};

addForm.addEventListener("submit", (event)=>{
    event.preventDefault();
    todoList.push({
    id: Math.floor(Math.random() * 100000).toString(),
    text: enterText.value,
    status:"pending",
});
enterText.value = "";
updateToDo();
});

pendingList.addEventListener("click",(event)=>{
    todoList.find(todo => todo.id === event.target.id).status = "completed";
    updateToDo();
});

completedList.addEventListener("click",(event)=>{
    todoList.find(todo => todo.id === event.target.id).status = "pending";
    updateToDo();
});