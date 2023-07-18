export interface RInstatControl {
  id: number;
  controlType: number;
  label: string | null;
  help: string | null;
  controlLink: number | null;
  min: number | null;
  max: number | null;
  defaultValue: string | null;
  possibleValues: Array<string> | null;
  controls: Array<RInstatControl> | null;
}

export interface RInstatContolValues {
  id: number;
  values: Array<string>;
}

export interface RFormValue {
  id: number;
  controlValues: Array<RInstatContolValues>;
}

export interface RControlAndValues {
  control: RInstatControl
  values: RInstatContolValues
}
