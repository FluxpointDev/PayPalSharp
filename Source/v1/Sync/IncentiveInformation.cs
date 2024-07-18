



// @data H4sIAAAAAAAC/7xVXWvcOhB9v79i8FMC3nXuvaWFfQsNhbQ0CW0olHRJZqXxWlSW3NEoW1Py34u83+vNR9vQJ2PNSHPO0ZnRj+yybSgbZadOkRNzS3DqSs81ivEuy7NPyAYnls6wTmlZnr2jdv1zQkGxabrkUXZZEZjVQZoEjQ3DLM+OmbGdVzrKsw+E+tzZNhuVaAOlhW/RMOnVwgX7hlgMhWx0tQfjyfzoPr5V9Wu9SlkD3hfdZnDsABNW8OWjTF7+PpP33lH7EHqsfXRyD/hVsK++iszkVAvoNMzzoPQMCKVx6JRBC7doIw2YLAppKA1ZPYQ3noG+Y91YymGCFp0i8AwNtjU5AR3p+S4yCBs37fNfor9WXtMW+d1In/mVVEw0UBUyKiGG04/ngxf//ftqrUnaOz4otFehME5oyp3LC22YlBRMQYpl8iAlh+IQpEIBo5P0paEAsqHyLykiHHcEcdHau/xRVbr72lJjudJXoYvkMKuMqqA200pgQqMv8ejofxVt96X5nzXzv2MHnRbEnVEW1BJTa74S3Ly9+HwzFwGZwHkBaRuj0NoWyiS18Q7tcH5osTx1pwZoUqZGu9qxv9bl2clGrRAn2twaTToh9CCVjwGdlirsL1csGSYzp3vihfjgYj0hTk29BNJYVBQWvbHlkBwCEVy93lwLMEh+guSn8UEl0oRRUcxms6EJfuh5WpjgO7cNtg00rKS2h8/hk/ETnLIeEb0G6oX2zA6vqWd3dOs5mEOIqgIMSTIfG+/+dCQ8sQPW4Bv2U8b6IX47KQ+9UIvUe5hDTawqdALWt2ilTfOwt/mvSyApcT/1RahPOQW2nrTNqwwNde+CL8vUI/ycdzu+G9/98xMAAP//
using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Sync
{
    /// <summary>
    /// The incentive details.
    /// </summary>

    public class IncentiveInformation
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public IncentiveInformation() { }

        /// <summary>
        /// An array of incentive details.
        /// </summary>
        [JsonPropertyName("incentive_details")]
        public List<IncentiveDetails> IncentiveDetails;
    }
}

