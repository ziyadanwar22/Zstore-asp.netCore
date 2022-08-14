namespace Admin.ProductImage {
    export interface ProductImageForm {
        Productid: Serenity.IntegerEditor;
        Image: Serenity.StringEditor;
    }

    export class ProductImageForm extends Serenity.PrefixedContext {
        static formKey = 'ProductImage.ProductImage';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProductImageForm.init)  {
                ProductImageForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;

                Q.initFormType(ProductImageForm, [
                    'Productid', w0,
                    'Image', w1
                ]);
            }
        }
    }
}
