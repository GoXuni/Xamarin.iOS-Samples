using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace FlexGridSample
{
	public static class License
	{
		public const string Key = "AB4BHgIeB4ZGAGwAZQB4AEcAcgBpAGQAMQAwADEAkf7VqlwSWAIrBuSL65BELUqK3YI1Cb3rb" +
			"ZFzoCwnGe1wt3JkXahSdQG7hGfuTcx/YqkghlGRBS4MiZ4Q4IGSpKKpM5YVaC3IAR5GB48NAhyHagUzdZdr2J/mrfU85xdF" +
			"/Oca3ndHbigKLTbax5EhIplWEGjcgp/Shd6d/YXb9O5TYxkjCQZRhG+M2FixYW5O4PO7YsSN9xwpG16jcPyawoVgZcHo26k" +
			"RtjBzeWBvtauJT8IfKEqzbreYPsJA5fHWL5/weR4cbLi7gb2aXm2GlMb2ROW/mu+dMRHj1JwBZej/emuIq0svBF6ziwIkbL" +
			"2+hlsXmhUwg3RSawvwznlh3JSEJSqvlwYeBR9P3V6o0Yn6eOSM0yBwXFc3fILOzxEbJSkmV5GTDWaf9z/l19jnBeQgOckm5" +
			"JLzzol4ryXEWA2UHjCLkpfYxwVtmjTXbnlO4RGc+tmeFQ6LuMx2Fd7SgT3lNLQ4nhK3fOGZXjwNClVut9B0XQFG7NlMfrpy" +
			"M+TAcOTnjnHaotzmZdRamwy/5cyRAmVZI5JaPt5xoOSga9REoPkborcmtsY/lWam30Gq4jc5BQA5Cr99iwywVx5P6Tdp27v" +
			"mzY+1phcAAETmOY9GB0FrUDWirSuqLutWr9zqYWIjg4YFLeQELGIE04lshXnxvWBJIjDlIGbEiel8Bw4wggVkMIIETKADAg" +
			"ECAhAiELIXSwsSf7soBS4RsyUKMA0GCSqGSIb3DQEBBQUAMIG0MQswCQYDVQQGEwJVUzEXMBUGA1UEChMOVmVyaVNpZ24sI" +
			"EluYy4xHzAdBgNVBAsTFlZlcmlTaWduIFRydXN0IE5ldHdvcmsxOzA5BgNVBAsTMlRlcm1zIG9mIHVzZSBhdCBodHRwczov" +
			"L3d3dy52ZXJpc2lnbi5jb20vcnBhIChjKTEwMS4wLAYDVQQDEyVWZXJpU2lnbiBDbGFzcyAzIENvZGUgU2lnbmluZyAyMDE" +
			"wIENBMB4XDTEzMDkyNDAwMDAwMFoXDTE2MTAyMzIzNTk1OVowgacxCzAJBgNVBAYTAlVTMRUwEwYDVQQIEwxQZW5uc3lsdm" +
			"FuaWExEzARBgNVBAcTClBpdHRzYnVyZ2gxFTATBgNVBAoUDENvbXBvbmVudE9uZTE+MDwGA1UECxM1RGlnaXRhbCBJRCBDb" +
			"GFzcyAzIC0gTWljcm9zb2Z0IFNvZnR3YXJlIFZhbGlkYXRpb24gdjIxFTATBgNVBAMUDENvbXBvbmVudE9uZTCCASIwDQYJ" +
			"KoZIhvcNAQEBBQADggEPADCCAQoCggEBALnLoJqpSVVqnJLza05lTIcakcvyl7dxBxZ+cwk4Cqk6+UaC6f5Z5LvRD1+AhiA" +
			"RulIgI7vPgkCf+c83iOViQWyJuXFJMnGava3AZ6X/o0DaUqzYzFOWz/MrAzOJvYMtrj/NT9m8BWei+UkY1NWUytiSa0JINY" +
			"t55i/FztxXtP7K27Lj3ZYwwUkNLOKJ4f+qkR0QSnygYUQQyMDOLg5vfYkDLdUQkNretBT2JZ6x6dkNcCpif5dbZ01MOFEEj" +
			"ZJlGdnvrenuOYfw5CNloDSCRzttSJ89JtJOjQxyrBQf1ylOXoiXCPpzAXCU2SF/dYXSimVM8pT0NZ7pUNG1H+Az2nMCAwEA" +
			"AaOCAXswggF3MAkGA1UdEwQCMAAwDgYDVR0PAQH/BAQDAgeAMEAGA1UdHwQ5MDcwNaAzoDGGL2h0dHA6Ly9jc2MzLTIwMTA" +
			"tY3JsLnZlcmlzaWduLmNvbS9DU0MzLTIwMTAuY3JsMEQGA1UdIAQ9MDswOQYLYIZIAYb4RQEHFwMwKjAoBggrBgEFBQcCAR" +
			"YcaHR0cHM6Ly93d3cudmVyaXNpZ24uY29tL3JwYTATBgNVHSUEDDAKBggrBgEFBQcDAzBxBggrBgEFBQcBAQRlMGMwJAYIK" +
			"wYBBQUHMAGGGGh0dHA6Ly9vY3NwLnZlcmlzaWduLmNvbTA7BggrBgEFBQcwAoYvaHR0cDovL2NzYzMtMjAxMC1haWEudmVy" +
			"aXNpZ24uY29tL0NTQzMtMjAxMC5jZXIwHwYDVR0jBBgwFoAUz5mp6nsm9EvJjo/X8AUm7+PSp50wEQYJYIZIAYb4QgEBBAQ" +
			"DAgQQMBYGCisGAQQBgjcCARsECDAGAQEAAQH/MA0GCSqGSIb3DQEBBQUAA4IBAQBhzVY5zjwYAFjmIa2JSWbqeXQ1jrf2o5" +
			"DoRYWgI/+4LEpJ+U2o+VAI5kIYSNGp5Yjq7XvQosjs/C6qdwpfTd3bh2lEER4XCRzpo+4HK9Wxwj0D8P1UoUn43LjlbMB/G" +
			"zRRhNq0BN+ETlD0+BejspoUssd5GRhGLNOXmtDV+9/a7j7h9t5JEMk++JblysVe6UpcgtoY9XguZLsm5DOhQT0QIlgOIK1Q" +
			"Sl/whiKGdPBfD5jN4/SHsGVUbPpC+Pxjh5yT/LSm9+Nqk+tzMQQcpbTfeLKs9kLgsG4Uo9fsg5wOl4FN4CBHo2CLXEqtriy" +
			"3//rpUMOutVKmm1awHhgGqsuFMIICuDCCAaCgAwIBAgIIA4BNRfNjh0UwDQYJKoZIhvcNAQEFBQAwHDEaMBgGA1UEAwwRR0" +
			"MtWFUxMTUwMC0xNDAwMjIwHhcNMTUwMTAxMDAwMDAwWhcNMTYwNDMwMDAwMDAwWjAcMRowGAYDVQQDDBFHQy1YVTExNTAwL" +
			"TE0MDAyMjCCASIwDQYJKoZIhvcNAQEBBQADggEPADCCAQoCggEBALIC2fLrGcFcpDQW2q/Ji12ubkVQq25/fjpqx8HH0pGt" +
			"88xcKtXHFRnVRzEiZTdHiFgwnNyKN0I/auYS3BtXXMERvV/n4/58ziAnvPbXmw7Deh4CrVChTzFRi1OcAONSIo4mv4H/CHT" +
			"YFwAvjX39XOWZI6LjU1pY5R1lYf2dwqmouItKAhalSzR0+X29b7u43W1wNqUv8k9xgen891RRixsbxKutVcWSeHxg1Uu6Rd" +
			"fWXRxtmMiteV+i7RReiux2FqVDz01xUZwQFhKX07q5BietRKA2OOmDxOBNkRE0Xe+jR4GyBLdTMlTL/P5XPh+CUzeA1ema6" +
			"uyQzeY4BcVBNNsCAwEAATANBgkqhkiG9w0BAQUFAAOCAQEAbhZ3f5orEmJaHXGKEL+9r5wzjRcr+DHkEm4Q6O7lSgLtqV7q" +
			"A3a1YfOeb7ySdpzLntgPJUusgTDljGUWJiU6mioGSjnadJHOsb73MSnFFU6vVqwfSJCpj5XaeJCozXX2mjM1536YM3NH88v" +
			"3j5X7IrDv8XsTp6r38wc7ZJMf9SboQEVDLwI3WLsArTDJGxvcYZUUQooMkIdBSi7r/AgfC0CxmiUJpeH36LwG9EfIOJPH9+" +
			"xN8NJXAL80+THKukzh7NoAX4lCm8t/g8IeKGWSWHJOegdYB0Nb04EYawOtwAEbyAO7JSFe+URrr0VwC6GvNqF8lFPAM8badjmHnlpVgQ==";
	}

}