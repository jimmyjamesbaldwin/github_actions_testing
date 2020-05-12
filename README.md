# jamesbaldwin.co.uk

![Build and Deploy](https://github.com/jimmyjamesbaldwin/github_actions_testing/workflows/Build%20and%20Deploy/badge.svg)

[www.jamesbaldwin.co.uk](https://www.jamesbaldwin.co.uk)

<img src="https://i2.wp.com/www.jasonbytes.com/wp-content/uploads/2019/12/fucntions.png" width="100"><img src="https://cdn.clipart.email/3707b13e1d52c6435ba7eb6466b5298e_github-actions-github_200-200.png" width="100"><img src="https://dotnetdevlife.files.wordpress.com/2018/04/resource-group.png" width="100">

A very minialist personal website built using Azure Functions, infrastructure provisioned with ARM templates, and deployed with GitHub Actions.

### ARM Template Deployment
Create a resource group, deploy an Azure Function (consumption plan), with a storage account for logs...
```
# create resource group
az group create -n jamesbaldwin.co.uk -l uksouth

# deploy it
az group deployment create -n jamesbaldwin.co.uk -g jamesbaldwin.co.uk --template-file "deployment\arm.deployment.json" --parameters "deployment\arm.parameters.json" 
```

### Service Principal Creation
Create a Service Principal that can be used to manage the Azure Function, which we can add to the GitHub repository as a Secret. Don't commit this to the repo...
```
az ad sp create-for-rbac --name "jamesbaldwin.co.uk" --role contributor --scopes /subscriptions/10233f3f-7dce-4193-934b-53b125b85da4/resourceGroups/jamesbaldwin.co.uk/providers/Microsoft.Web/sites/jamesbaldwinypw5g --sdk-auth
```

### GitHub Actions
GitHub Actions is used as the CI tool for this project, which builds the dotnet project and deploys the latest code to the Azure Function. GitHub picks up files in the .github/workflows directory and will run the pipeline upon new merges to master:

[.github/workflows/ci.yml](https://github.com/jimmyjamesbaldwin/github_actions_testing/blob/master/.github/workflows/ci.yml)
![asd](https://i.imgur.com/bsvneOl.jpg)
