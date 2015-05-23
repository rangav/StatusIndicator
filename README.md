## StatusIndicator
Xamarin iOS activity indicator example

### Install RestSharp
Install Restsharp component from here
https://components.xamarin.com/view/restsharp/

RestSharp is used to make async rest api calls

### Usage
```
ActivityHelper progress = new ActivityHelper();
```

Before Async call
```
progress.ShowProgressView (tableViewMessages);
```

After api finish download data
```
tableViewMessages.Source = new TableSource (messages);
tableViewMessages.ReloadData ();
progress.HideProgressView();
```

###### References
Inspired from iOS swift examples below

https://coderwall.com/p/su1t1a/ios-customized-activity-indicator-with-swift
https://github.com/Isuru-Nanayakkara/IJProgressView


<img src="https://raw.githubusercontent.com/rangav/StatusIndicator/master/StatusIndicator/ActivityIndicator.png" height="426" width="240" >
