// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

public sealed class AppMessageDeliveryDTO
     : IPropagatePropertyAccessPath
{
    public AppMessageDeliveryDTO() { }
    
    public AppMessageDeliveryDTO(string id, AppMessageDeliveryType messageType, bool successful, DateTime sentAt, string duration, string method, WebhookRecord? webhook = null, string? deliveryId = null, string? url = null, List<HttpHeaderDTO>? requestHeaders = null, string? requestBody = null, int? responseStatusCode = null, List<HttpHeaderDTO>? responseHeaders = null, string? responseBody = null, AppMessageDeliveryDTOClientErrorDTO? httpClientError = null)
    {
        Id = id;
        MessageType = messageType;
        Webhook = webhook;
        DeliveryId = deliveryId;
        IsSuccessful = successful;
        SentAt = sentAt;
        Duration = duration;
        Method = method;
        Url = url;
        RequestHeaders = requestHeaders;
        RequestBody = requestBody;
        ResponseStatusCode = responseStatusCode;
        ResponseHeaders = responseHeaders;
        ResponseBody = responseBody;
        HttpClientError = httpClientError;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(AppMessageDeliveryDTO), nameof(Id));
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue();
        set => _id.SetValue(value);
    }

    private PropertyValue<AppMessageDeliveryType> _messageType = new PropertyValue<AppMessageDeliveryType>(nameof(AppMessageDeliveryDTO), nameof(MessageType));
    
    [Required]
    [JsonPropertyName("messageType")]
    public AppMessageDeliveryType MessageType
    {
        get => _messageType.GetValue();
        set => _messageType.SetValue(value);
    }

    private PropertyValue<WebhookRecord?> _webhook = new PropertyValue<WebhookRecord?>(nameof(AppMessageDeliveryDTO), nameof(Webhook));
    
    [JsonPropertyName("webhook")]
    public WebhookRecord? Webhook
    {
        get => _webhook.GetValue();
        set => _webhook.SetValue(value);
    }

    private PropertyValue<string?> _deliveryId = new PropertyValue<string?>(nameof(AppMessageDeliveryDTO), nameof(DeliveryId));
    
    [JsonPropertyName("deliveryId")]
    public string? DeliveryId
    {
        get => _deliveryId.GetValue();
        set => _deliveryId.SetValue(value);
    }

    private PropertyValue<bool> _successful = new PropertyValue<bool>(nameof(AppMessageDeliveryDTO), nameof(IsSuccessful));
    
    [Required]
    [JsonPropertyName("successful")]
    public bool IsSuccessful
    {
        get => _successful.GetValue();
        set => _successful.SetValue(value);
    }

    private PropertyValue<DateTime> _sentAt = new PropertyValue<DateTime>(nameof(AppMessageDeliveryDTO), nameof(SentAt));
    
    [Required]
    [JsonPropertyName("sentAt")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime SentAt
    {
        get => _sentAt.GetValue();
        set => _sentAt.SetValue(value);
    }

    private PropertyValue<string> _duration = new PropertyValue<string>(nameof(AppMessageDeliveryDTO), nameof(Duration));
    
    [Required]
    [JsonPropertyName("duration")]
    public string Duration
    {
        get => _duration.GetValue();
        set => _duration.SetValue(value);
    }

    private PropertyValue<string> _method = new PropertyValue<string>(nameof(AppMessageDeliveryDTO), nameof(Method));
    
    [Required]
    [JsonPropertyName("method")]
    public string Method
    {
        get => _method.GetValue();
        set => _method.SetValue(value);
    }

    private PropertyValue<string?> _url = new PropertyValue<string?>(nameof(AppMessageDeliveryDTO), nameof(Url));
    
    [JsonPropertyName("url")]
    public string? Url
    {
        get => _url.GetValue();
        set => _url.SetValue(value);
    }

    private PropertyValue<List<HttpHeaderDTO>?> _requestHeaders = new PropertyValue<List<HttpHeaderDTO>?>(nameof(AppMessageDeliveryDTO), nameof(RequestHeaders));
    
    [JsonPropertyName("requestHeaders")]
    public List<HttpHeaderDTO>? RequestHeaders
    {
        get => _requestHeaders.GetValue();
        set => _requestHeaders.SetValue(value);
    }

    private PropertyValue<string?> _requestBody = new PropertyValue<string?>(nameof(AppMessageDeliveryDTO), nameof(RequestBody));
    
    [JsonPropertyName("requestBody")]
    public string? RequestBody
    {
        get => _requestBody.GetValue();
        set => _requestBody.SetValue(value);
    }

    private PropertyValue<int?> _responseStatusCode = new PropertyValue<int?>(nameof(AppMessageDeliveryDTO), nameof(ResponseStatusCode));
    
    [JsonPropertyName("responseStatusCode")]
    public int? ResponseStatusCode
    {
        get => _responseStatusCode.GetValue();
        set => _responseStatusCode.SetValue(value);
    }

    private PropertyValue<List<HttpHeaderDTO>?> _responseHeaders = new PropertyValue<List<HttpHeaderDTO>?>(nameof(AppMessageDeliveryDTO), nameof(ResponseHeaders));
    
    [JsonPropertyName("responseHeaders")]
    public List<HttpHeaderDTO>? ResponseHeaders
    {
        get => _responseHeaders.GetValue();
        set => _responseHeaders.SetValue(value);
    }

    private PropertyValue<string?> _responseBody = new PropertyValue<string?>(nameof(AppMessageDeliveryDTO), nameof(ResponseBody));
    
    [JsonPropertyName("responseBody")]
    public string? ResponseBody
    {
        get => _responseBody.GetValue();
        set => _responseBody.SetValue(value);
    }

    private PropertyValue<AppMessageDeliveryDTOClientErrorDTO?> _httpClientError = new PropertyValue<AppMessageDeliveryDTOClientErrorDTO?>(nameof(AppMessageDeliveryDTO), nameof(HttpClientError));
    
    [JsonPropertyName("httpClientError")]
    public AppMessageDeliveryDTOClientErrorDTO? HttpClientError
    {
        get => _httpClientError.GetValue();
        set => _httpClientError.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _id.SetAccessPath(path, validateHasBeenSet);
        _messageType.SetAccessPath(path, validateHasBeenSet);
        _webhook.SetAccessPath(path, validateHasBeenSet);
        _deliveryId.SetAccessPath(path, validateHasBeenSet);
        _successful.SetAccessPath(path, validateHasBeenSet);
        _sentAt.SetAccessPath(path, validateHasBeenSet);
        _duration.SetAccessPath(path, validateHasBeenSet);
        _method.SetAccessPath(path, validateHasBeenSet);
        _url.SetAccessPath(path, validateHasBeenSet);
        _requestHeaders.SetAccessPath(path, validateHasBeenSet);
        _requestBody.SetAccessPath(path, validateHasBeenSet);
        _responseStatusCode.SetAccessPath(path, validateHasBeenSet);
        _responseHeaders.SetAccessPath(path, validateHasBeenSet);
        _responseBody.SetAccessPath(path, validateHasBeenSet);
        _httpClientError.SetAccessPath(path, validateHasBeenSet);
    }

}
