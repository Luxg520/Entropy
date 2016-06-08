// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Primitives;
using TagHelperSample.Web.Models;
using TagHelperSample.Web.Services;

namespace TagHelperSample.Web.Components
{
    [ViewComponent(Name = "FeaturedMovies")]
    public class FeaturedMoviesComponent : ViewComponent
    {
        private readonly MoviesService _moviesService;

        public FeaturedMoviesComponent(MoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_moviesService.GetFeaturedMovies());
        }
    }
}