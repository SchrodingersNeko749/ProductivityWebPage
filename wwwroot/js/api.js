function GetCurrentProject() {

    fetch("/api/currentProject")   
    // Converting received data to JSON
    .then(response => response.json())
    .then(project => {
        $.fn.UpdateProject(project);
    })
    
}
function GetProjectTodo(projectId) {
    fetch("/api/projectTodo")
    .then(response => response.json())
    .then(todo =>{
        $.fn.UpdateTodo(todo);
    })
}
