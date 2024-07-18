



// @data H4sIAAAAAAAC/8xWTW/bRhC991cM2B5sgKICuHYT3QQkRYwGdeAovQhGOCJH4lbkLjMztMwW/e/FkiJtilVdoIba487sx3vzZt/u78GiLimYBe/uyWoQBr8gG1zl9DMWPhyEwU9UPw7ekiRsSjXOBrNgDjtaZc5tgfxysE7N2iTo01EQBnNmrNsDXoXBLWF6Y/M6mK0xF/KBr5VhSvvAR3YlsRqSYLbsoYmysZsxtoQJlb6oKWgAcxgfIl5kBCkqAdoU/AzYZWRBM/obKrBDgXbXNARjYXltldiSHuy1dlyg3p1lqqXMplN1LpfIkK4jx5tppkU+5XVycXHx5luhxO89uYyuzv9trWyV53+EzxasYfZF/aSn9RqEx+Vq66EZKiibzYaY0mcKdlI+98Ti0Y4pPWaOsdrP8Jo+ZfQfcDHpgEAzHKO+fgtufdrifzB2C0+QwM3qV0r+wipyY7cyINFFDkzDAnp4ngnT14pEJ0y5v1ywfD9fvLuZf4Jm6d3ZNHWJTLE00wyVHMqkSRxemKuXN5eMaT0gsw+MNUlcUeakBIq8IYXPtx8iWDgocEuNVB25BPM89NNXxraZgjRzKeyMZqCZkYZ26zCfb69BqSj90n/qK1eXP7w6j+DaJnmVtifE38UhxGdx2JhUfB5DkiFjosTit4WSaVKyS0jE2E0EnlHsucZgpNliSzV0sniuzvZ+0IgB2Jeg5djyQZBqJV5fq034RBeprelAuj40Fu/9YvGxk4H3p4MeEe9EDJjyAfx2PMa+9OVvAfp76Q382Ra5fPP6df/0fH8ewi4zSQZCfE8CKIDWm4zvDGzkbYWuLBYrs6lcJXkNaQNlRW1/CBVo1STSWZNfFsEnIlg25nG7RyiP6Ha7XWTQYoMNRczGFmRVpn7tpKN0OIwePI2XeS3vngjhjjgak7iKEzpQow+OJemS/8vnsgM3/gEcZsbELBbU6duT7O6GuqOvZ8v2RASlKgrkekDtMXb4dd1n9t3cvm2+77X/HQw0gh8dAz2gd7oQ4jmUWPueBaw0c2x+G30Vo/hlGvWbPwEAAP//
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json.Serialization;


namespace PayPal.v1.Webhooks
{
    /// <summary>
    /// A webhook event notification.
    /// </summary>

    public class Event<T>
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Event() { }

        /// <summary>
        /// The date and time when the webhook event notification was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTimeFormat;

        [JsonIgnore]
        public DateTime CreatedDate => DateTime.Parse(CreateTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

        /// <summary>
        /// The event that triggered the webhook event notification.
        /// </summary>
        [JsonPropertyName("event_type")]
        public string EventType;

        /// <summary>
        /// The event version in the webhook notification.
        /// </summary>
        [JsonPropertyName("event_version")]
        public string EventVersion;

        /// <summary>
        /// The ID of the webhook event notification.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/hateoas-links).
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// The resource that triggered the webhook event notification.
        /// </summary>
        [JsonPropertyName("resource")]
        public T Resource;

        /// <summary>
        /// The name of the resource related to the webhook notification event.
        /// </summary>
        [JsonPropertyName("resource_type")]
        public string ResourceType;

        /// <summary>
        /// A summary description for the event notification. For example, `A payment authorization was created.`
        /// </summary>
        [JsonPropertyName("summary")]
        public string Summary;
    }
}

