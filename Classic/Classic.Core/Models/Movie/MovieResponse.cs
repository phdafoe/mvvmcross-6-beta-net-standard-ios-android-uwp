﻿using Classic.Core.Models.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classic.Core.Models.Movie
{
    public class MovieResponse : BaseResponse
    {

        [JsonProperty("results")]
        public List<ResultMovie> Movies { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        //public Dates dates { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        public MovieResponse()
        {
        }
    }
}
