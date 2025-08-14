namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// The 'MATH' table constants, refer to
/// [OpenType documentation](https://docs.microsoft.com/en-us/typography/opentype/spec/math#mathconstants-table)
/// For more explanations.
/// </para>
/// </summary>

[Flags]
public enum hb_ot_math_constant_t
{
/// <summary>
/// <para>
/// scriptPercentScaleDown
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_SCRIPT_PERCENT_SCALE_DOWN = 0,
/// <summary>
/// <para>
/// scriptScriptPercentScaleDown
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_SCRIPT_SCRIPT_PERCENT_SCALE_DOWN = 1,
/// <summary>
/// <para>
/// delimitedSubFormulaMinHeight
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_DELIMITED_SUB_FORMULA_MIN_HEIGHT = 2,
/// <summary>
/// <para>
/// displayOperatorMinHeight
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_DISPLAY_OPERATOR_MIN_HEIGHT = 3,
/// <summary>
/// <para>
/// mathLeading
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_MATH_LEADING = 4,
/// <summary>
/// <para>
/// axisHeight
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_AXIS_HEIGHT = 5,
/// <summary>
/// <para>
/// accentBaseHeight
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_ACCENT_BASE_HEIGHT = 6,
/// <summary>
/// <para>
/// flattenedAccentBaseHeight
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_FLATTENED_ACCENT_BASE_HEIGHT = 7,
/// <summary>
/// <para>
/// subscriptShiftDown
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_SUBSCRIPT_SHIFT_DOWN = 8,
/// <summary>
/// <para>
/// subscriptTopMax
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_SUBSCRIPT_TOP_MAX = 9,
/// <summary>
/// <para>
/// subscriptBaselineDropMin
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_SUBSCRIPT_BASELINE_DROP_MIN = 10,
/// <summary>
/// <para>
/// superscriptShiftUp
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_SUPERSCRIPT_SHIFT_UP = 11,
/// <summary>
/// <para>
/// superscriptShiftUpCramped
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_SUPERSCRIPT_SHIFT_UP_CRAMPED = 12,
/// <summary>
/// <para>
/// superscriptBottomMin
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_SUPERSCRIPT_BOTTOM_MIN = 13,
/// <summary>
/// <para>
/// superscriptBaselineDropMax
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_SUPERSCRIPT_BASELINE_DROP_MAX = 14,
/// <summary>
/// <para>
/// subSuperscriptGapMin
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_SUB_SUPERSCRIPT_GAP_MIN = 15,
/// <summary>
/// <para>
/// superscriptBottomMaxWithSubscript
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_SUPERSCRIPT_BOTTOM_MAX_WITH_SUBSCRIPT = 16,
/// <summary>
/// <para>
/// spaceAfterScript
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_SPACE_AFTER_SCRIPT = 17,
/// <summary>
/// <para>
/// upperLimitGapMin
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_UPPER_LIMIT_GAP_MIN = 18,
/// <summary>
/// <para>
/// upperLimitBaselineRiseMin
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_UPPER_LIMIT_BASELINE_RISE_MIN = 19,
/// <summary>
/// <para>
/// lowerLimitGapMin
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_LOWER_LIMIT_GAP_MIN = 20,
/// <summary>
/// <para>
/// lowerLimitBaselineDropMin
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_LOWER_LIMIT_BASELINE_DROP_MIN = 21,
/// <summary>
/// <para>
/// stackTopShiftUp
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_STACK_TOP_SHIFT_UP = 22,
/// <summary>
/// <para>
/// stackTopDisplayStyleShiftUp
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_STACK_TOP_DISPLAY_STYLE_SHIFT_UP = 23,
/// <summary>
/// <para>
/// stackBottomShiftDown
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_STACK_BOTTOM_SHIFT_DOWN = 24,
/// <summary>
/// <para>
/// stackBottomDisplayStyleShiftDown
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_STACK_BOTTOM_DISPLAY_STYLE_SHIFT_DOWN = 25,
/// <summary>
/// <para>
/// stackGapMin
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_STACK_GAP_MIN = 26,
/// <summary>
/// <para>
/// stackDisplayStyleGapMin
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_STACK_DISPLAY_STYLE_GAP_MIN = 27,
/// <summary>
/// <para>
/// stretchStackTopShiftUp
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_STRETCH_STACK_TOP_SHIFT_UP = 28,
/// <summary>
/// <para>
/// stretchStackBottomShiftDown
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_STRETCH_STACK_BOTTOM_SHIFT_DOWN = 29,
/// <summary>
/// <para>
/// stretchStackGapAboveMin
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_STRETCH_STACK_GAP_ABOVE_MIN = 30,
/// <summary>
/// <para>
/// stretchStackGapBelowMin
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_STRETCH_STACK_GAP_BELOW_MIN = 31,
/// <summary>
/// <para>
/// fractionNumeratorShiftUp
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_FRACTION_NUMERATOR_SHIFT_UP = 32,
/// <summary>
/// <para>
/// fractionNumeratorDisplayStyleShiftUp
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_FRACTION_NUMERATOR_DISPLAY_STYLE_SHIFT_UP = 33,
/// <summary>
/// <para>
/// fractionDenominatorShiftDown
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_FRACTION_DENOMINATOR_SHIFT_DOWN = 34,
/// <summary>
/// <para>
/// fractionDenominatorDisplayStyleShiftDown
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_FRACTION_DENOMINATOR_DISPLAY_STYLE_SHIFT_DOWN = 35,
/// <summary>
/// <para>
/// fractionNumeratorGapMin
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_FRACTION_NUMERATOR_GAP_MIN = 36,
/// <summary>
/// <para>
/// fractionNumDisplayStyleGapMin
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_FRACTION_NUM_DISPLAY_STYLE_GAP_MIN = 37,
/// <summary>
/// <para>
/// fractionRuleThickness
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_FRACTION_RULE_THICKNESS = 38,
/// <summary>
/// <para>
/// fractionDenominatorGapMin
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_FRACTION_DENOMINATOR_GAP_MIN = 39,
/// <summary>
/// <para>
/// fractionDenomDisplayStyleGapMin
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_FRACTION_DENOM_DISPLAY_STYLE_GAP_MIN = 40,
/// <summary>
/// <para>
/// skewedFractionHorizontalGap
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_SKEWED_FRACTION_HORIZONTAL_GAP = 41,
/// <summary>
/// <para>
/// skewedFractionVerticalGap
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_SKEWED_FRACTION_VERTICAL_GAP = 42,
/// <summary>
/// <para>
/// overbarVerticalGap
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_OVERBAR_VERTICAL_GAP = 43,
/// <summary>
/// <para>
/// overbarRuleThickness
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_OVERBAR_RULE_THICKNESS = 44,
/// <summary>
/// <para>
/// overbarExtraAscender
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_OVERBAR_EXTRA_ASCENDER = 45,
/// <summary>
/// <para>
/// underbarVerticalGap
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_UNDERBAR_VERTICAL_GAP = 46,
/// <summary>
/// <para>
/// underbarRuleThickness
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_UNDERBAR_RULE_THICKNESS = 47,
/// <summary>
/// <para>
/// underbarExtraDescender
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_UNDERBAR_EXTRA_DESCENDER = 48,
/// <summary>
/// <para>
/// radicalVerticalGap
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_RADICAL_VERTICAL_GAP = 49,
/// <summary>
/// <para>
/// radicalDisplayStyleVerticalGap
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_RADICAL_DISPLAY_STYLE_VERTICAL_GAP = 50,
/// <summary>
/// <para>
/// radicalRuleThickness
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_RADICAL_RULE_THICKNESS = 51,
/// <summary>
/// <para>
/// radicalExtraAscender
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_RADICAL_EXTRA_ASCENDER = 52,
/// <summary>
/// <para>
/// radicalKernBeforeDegree
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_RADICAL_KERN_BEFORE_DEGREE = 53,
/// <summary>
/// <para>
/// radicalKernAfterDegree
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_RADICAL_KERN_AFTER_DEGREE = 54,
/// <summary>
/// <para>
/// radicalDegreeBottomRaisePercent
/// </para>
/// </summary>

	HB_OT_MATH_CONSTANT_RADICAL_DEGREE_BOTTOM_RAISE_PERCENT = 55
}
