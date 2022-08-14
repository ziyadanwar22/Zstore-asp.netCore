namespace Admin.souqcom {
    export interface CartForm {
        UserId: Serenity.StringEditor;
        ProductId: Serenity.IntegerEditor;
        Qty: Serenity.IntegerEditor;
    }

    export class CartForm extends Serenity.PrefixedContext {
        static formKey = 'souqcom.Cart';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CartForm.init)  {
                CartForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;

                Q.initFormType(CartForm, [
                    'UserId', w0,
                    'ProductId', w1,
                    'Qty', w1
                ]);
            }
        }
    }
}
