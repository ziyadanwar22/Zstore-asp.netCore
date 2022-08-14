namespace Admin.Product {
    export interface ProductForm {
        Name: Serenity.StringEditor;
        Decription: Serenity.StringEditor;
        Price: Serenity.DecimalEditor;
        Catid: Serenity.LookupEditor;
        Photo: Serenity.ImageUploadEditor;
        Type: Serenity.StringEditor;
        SupplierName: Serenity.StringEditor;
        EntryDate: Serenity.DateEditor;
        ReveiwUrl: Serenity.StringEditor;
        Quntity: Serenity.IntegerEditor;
    }

    export class ProductForm extends Serenity.PrefixedContext {
        static formKey = 'Product.Product';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProductForm.init)  {
                ProductForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DecimalEditor;
                var w2 = s.LookupEditor;
                var w3 = s.ImageUploadEditor;
                var w4 = s.DateEditor;
                var w5 = s.IntegerEditor;

                Q.initFormType(ProductForm, [
                    'Name', w0,
                    'Decription', w0,
                    'Price', w1,
                    'Catid', w2,
                    'Photo', w3,
                    'Type', w0,
                    'SupplierName', w0,
                    'EntryDate', w4,
                    'ReveiwUrl', w0,
                    'Quntity', w5
                ]);
            }
        }
    }
}
