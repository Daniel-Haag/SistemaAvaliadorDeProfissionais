import { TipoCargo } from "./tipoCargo.model";

export interface Cargo {
  cargoID: number
  nomeCargo: string
  tipoCargo: TipoCargo
}
