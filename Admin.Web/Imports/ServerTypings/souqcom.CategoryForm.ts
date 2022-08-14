namespace Admin.souqcom {
    export interface CategoryForm {
        Name: Serenity.StringEditor;
        Photo: Serenity.StringEditor;
        Description: Serenity.StringEditor;
    }

    export class CategoryForm extends Serenity.PrefixedContext {
        static formKey = 'souqcom.Category';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CategoryForm.init)  {
                CategoryForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(CategoryForm, [
                    'Name', w0,
                    'Photo', w0,
                    'Description', w0
                ]);
            }
        }
    }
}
