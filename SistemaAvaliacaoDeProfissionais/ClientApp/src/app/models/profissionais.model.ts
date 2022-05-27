import { Cargo } from "./cargo.model";
import { Setores } from "./setores.model";
import { StatusAvaliacao } from "./statusAvaliacao.model";

export interface Profissionais {
  profissionalID: number
  nome: string
  userName: string
  senha: string
  matricula: string
  setor: Setores
  cargo: Cargo
  admissao: string
  statusAvaliacao: StatusAvaliacao
  gestor: boolean
}
