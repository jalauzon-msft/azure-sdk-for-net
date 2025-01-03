// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// For schedules like: &apos;recur every month on the first Monday&apos; or
/// &apos;recur every 3 months on last Friday&apos;.
/// </summary>
public partial class ContainerServiceMaintenanceRelativeMonthlySchedule : ProvisionableConstruct
{
    /// <summary>
    /// Specifies the number of months between each set of occurrences.
    /// </summary>
    public BicepValue<int> IntervalMonths 
    {
        get { Initialize(); return _intervalMonths!; }
        set { Initialize(); _intervalMonths!.Assign(value); }
    }
    private BicepValue<int>? _intervalMonths;

    /// <summary>
    /// Specifies on which week of the month the dayOfWeek applies.
    /// </summary>
    public BicepValue<ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex> WeekIndex 
    {
        get { Initialize(); return _weekIndex!; }
        set { Initialize(); _weekIndex!.Assign(value); }
    }
    private BicepValue<ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex>? _weekIndex;

    /// <summary>
    /// Specifies on which day of the week the maintenance occurs.
    /// </summary>
    public BicepValue<ContainerServiceWeekDay> DayOfWeek 
    {
        get { Initialize(); return _dayOfWeek!; }
        set { Initialize(); _dayOfWeek!.Assign(value); }
    }
    private BicepValue<ContainerServiceWeekDay>? _dayOfWeek;

    /// <summary>
    /// Creates a new ContainerServiceMaintenanceRelativeMonthlySchedule.
    /// </summary>
    public ContainerServiceMaintenanceRelativeMonthlySchedule()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ContainerServiceMaintenanceRelativeMonthlySchedule.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _intervalMonths = DefineProperty<int>("IntervalMonths", ["intervalMonths"]);
        _weekIndex = DefineProperty<ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex>("WeekIndex", ["weekIndex"]);
        _dayOfWeek = DefineProperty<ContainerServiceWeekDay>("DayOfWeek", ["dayOfWeek"]);
    }
}
