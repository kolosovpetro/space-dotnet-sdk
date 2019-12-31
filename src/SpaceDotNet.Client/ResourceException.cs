using System;
using System.Net;
using JetBrains.Annotations;

namespace SpaceDotNet.Client
{
    /// <summary>
    /// Represents an exception thrown by <see cref="T:Connection" /> when a resource can not be accessed.
    /// </summary>
    [PublicAPI]
    public class ResourceException 
        : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:ResourceException" /> class.
        /// </summary>
        public ResourceException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ResourceException" /> class
        /// with a specific message, HTTP status code and HTTP response body.
        /// </summary>
        /// <param name="message">A message that describes the current exception.</param>
        public ResourceException(string message) 
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ResourceException" /> class
        /// with a specific message, HTTP status code and HTTP response body.
        /// </summary>
        /// <param name="message">A message that describes the current exception.</param>
        /// <param name="statusCode">The <see cref="T:System.Net.Http.HttpStatusCode" /> that was received from the server.</param>
        /// <param name="response">The HTTP response body that was received from the server.</param>
        public ResourceException(string message, HttpStatusCode statusCode, string response) 
            : base(message)
        {
            StatusCode = statusCode;
            Response = response;
        }
        
        /// <summary>
        /// The <see cref="T:System.Net.Http.HttpStatusCode" /> that was received from the server.
        /// </summary>
        public HttpStatusCode? StatusCode { get; }
        
        /// <summary>
        /// The HTTP response body that was received from the server.
        /// </summary>
        public string? Response { get; }

        /// <summary>
        /// Error received from Space.
        /// </summary>
        public SpaceError? Error { get; set; }
    }
}