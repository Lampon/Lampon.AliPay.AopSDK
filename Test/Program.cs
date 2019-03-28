using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aop.Api;
using Aop.Api.Request;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string serverUrl = "https://openapi.alipay.com/gateway.do";
            string appId = "2017080908114716";
            string privateKeyPem = "MIICXQIBAAKBgQDUA6hB3+VxAp61ccYHQcRu50F/+GQbp4A4KF+yPy895afaTIdrxb6DtoCJfxcedmcJXYxR0XECPlUVxewMZfO1CkqXrpORjHBQid5WrIaaMgdY1nagm20J5wQoejrHvVSGh7XINobSKVLZC7fezYkgCGBCMEgXYOOEZmMYXFFuTwIDAQABAoGBAIK5cpCTlew1elhUO48T7SOYsZlPNaKbiAKYWlEUhnN63CFM2J8KAWtDJ0QgOcgNp4BtzuxP4IdKmbngHKiUYEwbwZnpnVfpcGnOaMa8Lx4xvN4bCENw4bdjsaFn8ZqdeXgG8CZ/e/MmxXRwkjUWTpX5BiB+gzLP5Op1/MxgLOAhAkEA9e4+BDwlYhrR5bDXapHg/tOn9EgCZZ+aHw+Aoxfr47f5/XDStcDbU0Z+achUwjpBBaMT4aPjz5JVBYAPCp51vwJBANyx6nY9L14cE7dwf1v4JF4XSohFMZkjRVa9IhMpjtNvJCos87tB2g6WFjZFVT5Abm+vZ6MMKq3B9mMttrU/y3ECQCAxbrbZNL+R6TYbHyfZLs3M4SiOIJoy+VbljZ5L7Foj5Dq0ATE/rLZK/RNV4RqHy6k0Ps8DyDeM3UpaCB4IvjsCQFfInQ4zACha2qzYnpAif7S9ZvQVMclL8kSyLl+Y5CrNxoDQKJKPewDaSjOEGIgOcN8T0hFUwZUj1bFVeZtWqMECQQDk3z3gtXlqw9rbvdk/IxM1KJsCZOqA6njF9ndIrM1Ubpkq0ocK23qSSjpv80hhwcjhfJ8zV+5JN3C4xnO/XzNv";
            IAopClient client = new DefaultAopClient(serverUrl, appId, privateKeyPem, false);
            AlipayTradePagePayRequest alipayRequest = new AlipayTradePagePayRequest();
            alipayRequest.SetReturnUrl("http://www.baidu.com");
            alipayRequest.SetNotifyUrl("http://open.zhundao.net/web/SwAliNotifyUrl");
            alipayRequest.BizContent = "{" +
                                       "    \"out_trade_no\":\"" + DateTime.Now.ToString("yyyyMMddHHmmssff") + "\"," +
                                       "    \"product_code\":\"FAST_INSTANT_TRADE_PAY\"," +
                                       "    \"total_amount\":" + 20 + "," +
                                       "    \"subject\":\"会员升级\"," +
                                       "    \"body\":\"测试\"" +
                                        "  }";
            var ss = client.pageExecute(alipayRequest);
        }
    }
}
