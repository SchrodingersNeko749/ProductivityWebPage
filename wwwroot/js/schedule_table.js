$(document).ready(function(){
    let table = $("#todo-table");
    
    $(".day_cell").hover(function(){
      $(this).css("background-color","pink")
    },function(){
      $(this).css("background-color","#a734c7")
    })
     $.fn.AddTodo = function (todo) {
      var clone = $(".todo-template").clone()
      clone.attr('class', 'todo-row');
      clone.children()[0].innerHTML = todo.name;
      clone.children()[1].innerHTML = todo.description;
      clone.children()[2].innerHTML = todo.status;
      table.append(clone);
     };
  });
