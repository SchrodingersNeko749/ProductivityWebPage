function GetCurrentProject() {

    fetch("/api/currentProject")   
    // Converting received data to JSON
    .then(response => response.json())
    .then(project => {
        $.fn.UpdateProject(project);
    })
    
}
function GetProjectTodo(projectId) {
    fetch("/api/projectTodos?project_id="+projectId)
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
    const todo = {
        name: document.todoform.name,
        description: document.todoform.description,
    };
    const options = {
        method: 'POST',
        body: JSON.stringify(todo),
        headers: {
            'Content-Type': 'application/json'
        }
    }
    console.log(options)
    fetch("/api/addTodo", options)
    .then(res => res.json())
    .then(res => console.log(res));
}
