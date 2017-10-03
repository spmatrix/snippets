pipeline{
    agent none
    stages{
        stage('Checkout')
        {
            agent any
            steps
            {
                git branch: 'develop', credentialsId: 'MyGitHub', url: 'git@github.com:spmatrix/snippets.git'
            }
        }
        stage ("decide on build") {
            agent none
            steps{
                script{
               def userInput = input(message: 'Do you want to build?', ok: 'Yes', 
                        parameters: [booleanParam(defaultValue: true, 
                        description: 'some desc',name: 'Yes?')])
                }
            }
        }
        
        stage('Build')
        {
            agent any
            steps
            {
               echo userInput
            }
        }
    }
}