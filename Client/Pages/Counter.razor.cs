﻿using BlazorMovies.Client.Helpers;
using BlazorMovies.Shared.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Pages
{
    public partial class Counter
    {
        [Inject] SingletonService singleton { get; set; }
        [Inject] TransientService transient { get; set; }
        [Inject] IRepository repository { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private int currentCount = 0;
        private static int currentCountStatic = 0;

        [JSInvokable]
        public async Task IncrementCount()
        {
            currentCount++;

            //used in the services lesson
            transient.Value = currentCount;
            singleton.Value = currentCount;
            
            //used in lesson 31 Invoking C# Code from JS code
            currentCountStatic++;
            await js.InvokeVoidAsync("dotnetStaticInvocation");


        }

        private async Task IncrementCountJavascript()
        {
            await js.InvokeVoidAsync("dotnetInstanceInvocation", DotNetObjectReference.Create(this));
        }

        //This method may be called from within JS Code
        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }

        private List<Movie> movies;

        protected override void OnInitialized()
        {
            movies = repository.GetMovies();

        }
    }
}
