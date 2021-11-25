import { Categoria } from "./categoria";
import { FormaPagamento } from "./forma-pagamento";
import { ItemVenda } from "./item-venda";

export interface Venda {
    vendaId?: number;
    cliente: string;
    formaPagamentoId?: number;
    carrinhoId: string;
    criadoem?: Date;
}
