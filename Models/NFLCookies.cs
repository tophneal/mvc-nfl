using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace NFL.Models
{
    public class NFLCookies
    {
        private const string TeamsKey = "myteams";
        private const string Delimiter = "-";

        private IRequestCookieCollection requestCookies { get; set; }
        private IResponseCookies responseCookies { get; set; }

        public NFLCookies(IRequestCookieCollection cookies)
        {
            requestCookies = cookies;
        }

        public NFLCookies(IResponseCookies cookies)
        {
            responseCookies = cookies;
        }

        public void SetMyTeamIds(List<Team> myTeams)
        {
            List<string> ids = myTeams.Select(t => t.TeamId).ToList();
            string idsString = String.Join(Delimiter, ids);
            CookieOptions options = new CookieOptions { Expires = DateTime.Now.AddDays(30) };
            RemoveMyTeamsIds();
            responseCookies.Append(TeamsKey, idsString, options);
        }

        public string[] GetMyTeamsIds()
        {
            string cookie = requestCookies[TeamsKey];
            if (string.IsNullOrEmpty(cookies))
                return new string[] { };
            else
                return cookies.Split(Delimiter);
        }

        public void RemoveMyTeamsIds()
        {
            responseCookies.Delete(TeamsKey);
        }
    }
}
