module ROFLweb
    module UrlHelpers
        module_function

            def url_for(object)
                "http://example.com/#{unique_id(object)}"
            end

            def unique_id(object)
                if object.respond_to?(:to_unique_id)
                    object.to_unique_id
                end
            end
        end
    end

class ClientCode
