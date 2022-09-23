const sunrise = 5;
const daylight = 12;
const d = new Date();
const day_progress = (d.getHours()-sunrise)/daylight
$(document).ready(function(){
    GetCurrentProject();
    
    $.fn.clamp = function(number, min, max){
        if(number >= max)
        {
            return max;
        }
        else if(number <= min){
            return min
        }
        else
            return number;
    }
    $.fn.UpdateProject = function(project) {
        if(project == null)
        {
            $(".billboard-title").text("Chore")
        }
        else
        {
            $(".billboard-title").text(project.name)
            $("#description").text(project.description)
            $("#progress").text("Progress: "+project.progress+"%")
            $("#steak").text("Streak: "+project.streak+"%")
            GetProjectTodo(project.id)
        }
     };
     $.fn.UpdateTodo = function(todo) {
        if(todo == null)
        {
            $(".description").text("Chore")
        }
        else
        {
            $("#description").text(todo.description)
        }
     };
})
$("#bg2").ready(function(){
    
    $("#bg1").css("opacity", $.fn.clamp(0.7,0,0.99).toString())
    //$("#bg1").css("background-position-y", 100-$.fn.clamp(day_progress*100,0,100).toString()+"%")
});

// (d.getHours()-sunrise)/daylight*100
