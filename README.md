# github_actions_testing



###
```
# create resource group
az group create -n jamesbaldwin.co.uk -l uksouth

# deploy it
az group deployment create -n jamesbaldwin.co.uk -g jamesbaldwin.co.uk --template-file "deployment\arm.deployment.json" --parameters "deployment\arm.parameters.json" 
```


```
az ad sp create-for-rbac --name "jamesbaldwin.co.uk" --role contributor --scopes /subscriptions/<id>/resourceGroups/intune/providers/Microsoft.Web/sites/jamesbaldwin.co.uk --sdk-auth
```


###
add secret to github CI

###
