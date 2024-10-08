### Example 1: Create Cluster
```powershell
New-AzConnectedVMwareCluster -Name "test-cluster" -ResourceGroupName "test-rg" -Location "eastus" -ExtendedLocationName "/subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourcegroups/test-rg/providers/microsoft.extendedlocation/customlocations/test-cl" -ExtendedLocationType "CustomLocation" -InventoryItemId "/subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourceGroups/test-rg/providers/Microsoft.ConnectedVMwarevSphere/VCenters/test-vc/InventoryItems/domain-c649660" -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
```

```output
CustomResourceName           : 1040d770-249a-4b2c-b7f4-a2ed32b05f81
DatastoreId                  : {}
ExtendedLocationName         : /subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourcegroups/test-rg/providers/microsoft.extendedlocation/customlocations/test-cl
ExtendedLocationType         : CustomLocation
Id                           : /subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourceGroups/test-rg/providers/Microsoft.ConnectedVMwarevSphere/clusters/test-cluster
InventoryItemId              : /subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourceGroups/test-rg/providers/Microsoft.ConnectedVMwarevSphere/VCenters/test-vc/InventoryItems/domain-c649660
Kind                         :
Location                     : eastus
MoName                       : Cluster1
MoRefId                      : domain-c649660
Name                         : test-cluster
NetworkId                    : {}
ProvisioningState            : Succeeded
ResourceGroupName            : test-rg
Statuses                     : {{
                                 "type": "Ready",
                                 "status": "True",
                                 "lastUpdatedAt": "2023-10-06T10:45:36.1775643Z"
                               }, {
                                 "type": "Idle",
                                 "status": "True",
                                 "lastUpdatedAt": "2023-10-06T10:45:36.1775643Z"
                               }}
SystemDataCreatedAt          : 10/6/2023 10:45:17 AM
SystemDataCreatedBy          : xyz
SystemDataCreatedByType      : User
SystemDataLastModifiedAt     : 10/6/2023 10:45:17 AM
SystemDataLastModifiedBy     : xyz
SystemDataLastModifiedByType : User
Tag                          : {
                               }
TotalCpuMHz                  : 210624
TotalMemoryGb                : 383
Type                         : microsoft.connectedvmwarevsphere/clusters
UsedCpuMHz                   : 50475
UsedMemoryGb                 : 367989
Uuid                         : 1040d770-249a-4b2c-b7f4-a2ed32b05f81
VCenterId                    : /subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourceGroups/test-rg/providers/Microsoft.ConnectedVMwarevSphere/VCenters/test-vc
```

This command create a Cluster named `test-cluster` in a resource group named `test-rg`.