node('master') {
    
	// Code Quality Check is not possible for a C# project, as it must be run from a MS Windows server or PC.
	// See the project readme for instructions.
	    
	stage('Build') {
	 echo "Building..."
	 openshiftBuild bldCfg: 'news-api-client', showBuildLogs: 'true'	 
    }
	
	stage('Integration Tests') {
	 echo "Building..."
	 openshiftBuild bldCfg: 'news-api-client-tests', showBuildLogs: 'true'	 
    }	
}
