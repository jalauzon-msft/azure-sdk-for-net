// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// The object representing the policy for taking backups on an account.
/// Please note
/// Azure.ResourceManager.CosmosDB.Models.CosmosDBAccountBackupPolicy is the
/// base class. According to the scenario, a derived class of the base class
/// might need to be assigned here, or this property needs to be casted to one
/// of the possible derived classes.             The available derived classes
/// include Azure.ResourceManager.CosmosDB.Models.ContinuousModeBackupPolicy
/// and Azure.ResourceManager.CosmosDB.Models.PeriodicModeBackupPolicy.
/// </summary>
public partial class CosmosDBAccountBackupPolicy : ProvisionableConstruct
{
    /// <summary>
    /// The object representing the state of the migration between the backup
    /// policies.
    /// </summary>
    public BicepValue<BackupPolicyMigrationState> MigrationState { get => _migrationState; set => _migrationState.Assign(value); }
    private readonly BicepValue<BackupPolicyMigrationState> _migrationState;

    /// <summary>
    /// Creates a new CosmosDBAccountBackupPolicy.
    /// </summary>
    public CosmosDBAccountBackupPolicy()
    {
        _migrationState = BicepValue<BackupPolicyMigrationState>.DefineProperty(this, "MigrationState", ["migrationState"]);
    }
}
