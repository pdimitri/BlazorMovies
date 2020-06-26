
//This is used to demonstrate the use of JS functions from C# Code. Counterpart can be found in Counter.razor.cs
function my_function(message) {
    console.log("from Utilities.js file in wwwroot " + message);
}


//This is used to demonstrate how to use C# Functions from JS code. Counterpart can be found in Counter.razor.cs
function dotnetStaticInvocation() {
    DotNet.invokeMethodAsync("BlazorMovies.Client", "GetCurrentCount")
        .then(result => {
            console.log("count from javascript " + result);
        });
}

//From Lesson 32 Invoking Instance C# Methods from JS
function dotnetInstanceInvocation(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}