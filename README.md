# github_actions_testing

![Build and Deploy](https://github.com/jimmyjamesbaldwin/github_actions_testing/workflows/Build%20and%20Deploy/badge.svg)

abc

###
```
# create resource group
az group create -n jamesbaldwin.co.uk -l uksouth

# deploy it
az group deployment create -n jamesbaldwin.co.uk -g jamesbaldwin.co.uk --template-file "deployment\arm.deployment.json" --parameters "deployment\arm.parameters.json" 
```


```
az ad sp create-for-rbac --name "jamesbaldwin.co.uk" --role contributor --scopes /subscriptions/10233f3f-7dce-4193-934b-53b125b85da4/resourceGroups/jamesbaldwin.co.uk/providers/Microsoft.Web/sites/jamesbaldwinypw5g --sdk-auth
```


###
add secret to github CI

###
