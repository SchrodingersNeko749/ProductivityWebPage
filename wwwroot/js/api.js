function GetCurrentProject() {

    fetch("/api/currentProject")   
    // Converting received data to JSON
    .then(response => response.json())
    .then(project => {
        $.fn.UpdateBillboard(project);
    })
    
}
