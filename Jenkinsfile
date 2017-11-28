node('maven') {
    
	// Code Quality Check is not possible for a C# project, as it must be run from a MS Windows server or PC.
	// See the project readme for instructions.
	    
	stage('build') {
	 echo "Building..."
	 openshiftBuild bldCfg: 'news-api-client', showBuildLogs: 'true'	 
    }
	
}
