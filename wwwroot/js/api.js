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
async function PrepareTodo()
{
    tdprojectid = localStorage.getItem("projectid");
    tdname = document.todoform.name.value;
    tddescription = document.todoform.description.value;
 
    const todo = {
        "id" : 0,
        "projectId" : tdprojectid,
        "name" : tdname,
        "description" : tddescription,
        "status" : "string"
    }

    console.log(todo)
    const options = {
        method: 'POST',
        headers: {
          'Accept': 'application/json',
          'Content-Type': 'application/json'
        },
        body: JSON.stringify(todo)
    }
    console.log(options)

    const resp = await fetch("/api/addTodo", options)
    console.log(resp)
}
