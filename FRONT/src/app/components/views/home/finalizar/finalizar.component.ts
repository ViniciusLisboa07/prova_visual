import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FormaPagamento } from 'src/app/models/forma-pagamento';
import { Venda } from 'src/app/models/venda';
import { FormaPagamentoService } from 'src/app/services/forma-pagemento.service';
import { VendaService } from 'src/app/services/venda.service';

@Component({
  selector: 'app-finalizar',
  templateUrl: './finalizar.component.html',
  styleUrls: ['./finalizar.component.css']
})
export class FinalizarComponent implements OnInit {

  nome!: string;
  formaPagamento!: number;
  formasDePagamentos: FormaPagamento[] = [];

  constructor(private serviceForma: FormaPagamentoService,
    private ServiceVenda: VendaService,
    private router: Router
    ) { }

  ngOnInit(): void {
    this.serviceForma.list().subscribe((formas) => {
        this.formasDePagamentos = formas;
    });
  }

  cadastrarVenda(): void {
    let carrinhoId = localStorage.getItem("carrinhoId")! || "";

    let venda: Venda = {
        cliente: this.nome,
        carrinhoId: carrinhoId,
        formaPagamentoId: this.formaPagamento
    }
    console.log(venda);
    console.log(this.formaPagamento);
    this.ServiceVenda.create(venda).subscribe(() => {
        this.router.navigate(["produto/listar"]);
    });
  }
}
