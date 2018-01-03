var exec = require('child_process').exec;
var child;

var command = "autorest --verbose --input-file=" + __dirname + '/swagger.json' + " --output-folder=" + __dirname + "/generated  --csharp --use-datetimeoffset --generate-empty-classes --override-client-name=Client  --namespace=namespace=Gov.News.Api";

child = exec(command, function(err, stdout, stderr) {
    console.log('stderr' + stderr);
    console.log('stdout' + stdout);
});