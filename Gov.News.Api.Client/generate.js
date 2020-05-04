var exec = require('child_process').exec;
var child;
var path = require ('path');
var https = require('https');
var fs = require('fs');
var url = "https://dev.api.news.gov.bc.ca/swagger/v1/swagger.json";
var dest = __dirname + path.sep + "swagger.json";

console.log("using node version ", process.version);

var cb = function() {
	var command = "autorest --verbose --input-file=" + __dirname + "/swagger.json --output-folder=" + __dirname + "/generated  --csharp --use-datetimeoffset --generate-empty-classes --override-client-name=Client  --namespace=Gov.News.Api";

	child = exec(command, function(err, stdout, stderr) {
		console.log('stderr' + stderr);
		console.log('stdout' + stdout);
	});
}

var download = function(url, dest, cb) {
  console.log ("Download URL is " + url);
  console.log ("Destination is " + dest);
  var file = fs.createWriteStream(dest);
  var request = https.get(url, function(response) {
    response.pipe(file);
    file.on('finish', function() {
      file.close(cb);  // close() is async, call cb after close completes.
    });
  });
}

// invoke the download...
download (url, dest, cb);

