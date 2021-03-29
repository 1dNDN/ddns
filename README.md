Usage:
```
docker run --rm -d -e RawIPSource="https://api.ipify.org" -e PddToken="pdd_token" -e Domain="domain" -e Subdomain="@" -e RecordID="id" -e TTL="ttl" 1dndn/ddns
```

Get pdd token here: https://pddimp.yandex.ru/api2/admin/get_token  
Get record id (record_id in response JSON) here:  
https://pddimp.yandex.ru/api2/admin/dns/list?domain=your_domain  
and PddToken:your_toren in headers.

Use  
```
docker pull 1dndn/ddns
```
for update app
