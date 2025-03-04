﻿using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace FSRMod
{
    public class CasterSetStoredValueEffect : EffectSO
    {
        [SerializeField]
        public UnitStoredValueNames _valueName = UnitStoredValueNames.None;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = entryVariable;
            caster.SetStoredValue(_valueName, entryVariable);
            return true;
        }
    }
    public class TargetSetStoredValueEffect : EffectSO
    {
        [SerializeField]
        public UnitStoredValueNames _valueName = UnitStoredValueNames.None;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            foreach (TargetSlotInfo target in targets)
            {
                if (target.HasUnit)
                {
                    target.Unit.SetStoredValue(_valueName, entryVariable);
                    exitAmount += entryVariable;
                }
            }
            return exitAmount > 0;
        }
    }
    public class TargetChangeStoredValueEffect : EffectSO
    {
        [SerializeField]
        public UnitStoredValueNames _valueName = UnitStoredValueNames.None;
        [SerializeField]
        public bool Increase;
        [SerializeField]
        public int Minimum = 0;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            foreach (TargetSlotInfo target in targets)
            {
                if (target.HasUnit)
                {
                    int orig = target.Unit.GetStoredValue(_valueName);
                    int set = Math.Max(Minimum, orig + (Increase ? entryVariable : (entryVariable * -1)));
                    caster.SetStoredValue(_valueName, set);
                    exitAmount += Math.Abs(orig - set);
                }
            }
            return exitAmount > 0;
        }
    }
}
