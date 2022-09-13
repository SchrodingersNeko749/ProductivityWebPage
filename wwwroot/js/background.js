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
    $.fn.UpdateBillboard = function(project) {
        $(".table_title").text(project.name)
     };
})
$("#bg2").ready(function(){
    
    $("#bg1").css("opacity", $.fn.clamp(day_progress,0,0.99).toString())
    $("#bg1").css("background-position-y", 100-$.fn.clamp(day_progress*100,0,100).toString()+"%")
});

// (d.getHours()-sunrise)/daylight*100
