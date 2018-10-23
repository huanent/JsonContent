# JsonContent
Let HttpClient support JsonContent

# use guide
```
var client=new HttpClient();
var content=new JsonContent(new{
    Name="jobs"，
    Age=23
});
var result=client.PostAsync("http://www.baidu.com",content).Result;
var success= result.Content.ReadAsJsonAsync<bool>().result
```