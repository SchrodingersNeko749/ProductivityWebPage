function GetCurrentProject() {

    fetch("/api/currentProject")   
    // Converting received data to JSON
    .then(response => response.json())
    .then(project => {
        $.fn.UpdateProject(project);
    })
    
}
function GetProjectTodo(projectId) {
    fetch("/api/projectTodos")
    .then(response => response.json())
    .then(todos =>{
        todos.forEach(todo => {
            $.fn.AddTodo(todo);
        });
    })
}
function PrepareTodo()
{
    alert("adaw")
    console.log(document.todoform.name, document.todoform.description)
}
