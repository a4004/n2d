using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;

namespace N2D22.API
{
    public class GithubManager
    {
        /// <summary>
        /// Makes an API request to the given URL (designed for Github).
        /// </summary>
        /// <param name="content">The raw content of the request.</param>
        /// <param name="url">The url to make the request to.</param>
        /// <param name="args">URL encoded parameters.</param>
        /// <returns>HTTP Status code.</returns>
        public static HttpStatusCode MakeApiRequestGet(out string content, string url, params string[] args)
        {
            HttpClient httpClient = new HttpClient();

            HttpRequestMessage httpRequest = new HttpRequestMessage()
            {
                RequestUri = new Uri(args == null ? url : $"{url}?{string.Join("&", args)}"),
                Method = HttpMethod.Get,
                Version = HttpVersion.Version11
            };

            httpRequest.Headers.Add("Accept", "application/json");
            httpRequest.Headers.Add("User-Agent", $"N2D22webAPI/{Environment.OSVersion.VersionString}");

            HttpResponseMessage httpResponse = httpClient.SendAsync(httpRequest,
                HttpCompletionOption.ResponseContentRead).GetAwaiter().GetResult();

            content = httpResponse.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            Program.Debug("github", $"Request {(args == null ? url : $"{url}?{string.Join("&", args)}")}");
            Program.Debug("github", $"Headers\r\n\t{string.Join("\t", httpRequest.Headers.ToString().Split('\n')).Replace("\r", "\r\n")}");
            Program.Debug("github", $"Status Code {httpResponse.StatusCode} ({(int)httpResponse.StatusCode})", 
                httpResponse.StatusCode == HttpStatusCode.OK ? Event.Success : Event.Warning);

            return httpResponse.StatusCode;
        }
        /// <summary>
        /// Returns the names of all the release asset files.
        /// </summary>
        /// <param name="repository">Github user/repo</param>
        /// <param name="tag">The release tag.</param>
        /// <returns>String array containing the file names.</returns>
        public static string[] GetReleaseNames(string repository, string tag)
        {
            if (MakeApiRequestGet(out string content, $"https://api.github.com/repos/{repository}/releases/tags/{tag}",
               null) == HttpStatusCode.OK)
            {
                return JsonDocument.Parse(content).RootElement.GetProperty("assets").EnumerateArray()
                    .Select(e => e.GetProperty("name").ToString()).ToArray();
            }
            else
            {
                Program.Debug("github", $"The API request was unsuccessful, raw content: {content}", Event.Critical);
                return null;
            }
        }
        /// <summary>
        /// Returns all the tags of a repo.
        /// </summary>
        /// <param name="repository">The user/repo.</param>
        /// <returns>String array of tags.</returns>
        public static string[] GetReleaseTags(string repository) 
        {
            if (MakeApiRequestGet(out string content, $"https://api.github.com/repos/{repository}/tags",
               null) == HttpStatusCode.OK)
            {
                return JsonDocument.Parse(content).RootElement.EnumerateArray().Select(e => e.GetProperty("name").ToString()).ToArray();
            }
            else
            {
                Program.Debug("github", $"The API request was unsuccessful, raw content: {content}", Event.Critical);
                return null;
            }
        }
        /// <summary>
        /// Gets the latest release tag.
        /// </summary>
        /// <param name="repository">The user/repo.</param>
        /// <returns>Single string equating the tag.</returns>
        public static string GetLatestTag(string repository)
        {
            if (MakeApiRequestGet(out string content, $"https://api.github.com/repos/{repository}/releases/latest",
                null) == HttpStatusCode.OK)
            {
                return JsonDocument.Parse(content).RootElement.GetProperty("tag_name").ToString();
            }
            else
            {
                Program.Debug("github", $"The API request was unsuccessful, raw content: {content}", Event.Critical);
                return null;
            }
        }
    }
}
