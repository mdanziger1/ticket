<template>
    <v-container fill-height fluid grid-list-xl class="pl-3 pt-3">
        <v-layout wrap>
            <v-flex xs8 class="pb-2">
                <v-card
                    style="border: 2px solid rgb(76, 175, 80); box-shadow: 5px 5px 2px #c7ced8;"
                >
                    <div v-if="loading" class="px-3 mt-2 py-2">
                        <v-progress-linear
                            :indeterminate="true"
                            color="success"
                        ></v-progress-linear>
                    </div>
                    <v-layout row justify-space-between>
                        <v-layout column class="ma-1 px-3">
                            <v-card-text
                                class="mb-0 pb-0 pt-2 pl-2"
                                v-if="request && request.id"
                            >
                                <div
                                    class="headline pt-2 mt-1 font-weight-bold mb-0 ml-0"
                                >
                                    {{ request.subject }}
                                </div>
                                <div class="my-2 body-1 font-weight-light">
                                    Requested By:
                                    <span class="font-weight-medium">{{
                                        request.name
                                    }}</span>
                                    On:
                                    <span class="font-weight-medium">{{
                                        request.createdAt | time
                                    }}</span>
                                </div>
                                <v-divider></v-divider>
                                <div class="ml-0 mt-4">
                                    <div class="pl-3">
                                        <v-layout row class="mb-2">
                                            <div
                                                class="font-weight-medium mr-2"
                                            >
                                                Requester Email:
                                            </div>
                                            <div>
                                                {{ request.requesterEmail }}
                                            </div>
                                        </v-layout>
                                        <v-layout row class="mb-2">
                                            <div
                                                class="font-weight-medium mr-2"
                                            >
                                                Ticket Number:
                                            </div>
                                            <div>
                                                {{ "#" + request.displayID }}
                                            </div>
                                        </v-layout>
                                        <v-layout row class="mb-2">
                                            <div
                                                class="font-weight-medium mr-2"
                                            >
                                                Technician:
                                            </div>
                                            <div>
                                                {{ getTechnician() }}
                                            </div>
                                        </v-layout>
                                        <v-layout row class="mb-2">
                                            <div
                                                class="font-weight-medium mr-2"
                                            >
                                                Site:
                                            </div>
                                            <div>
                                                {{ request.siteName }}
                                            </div>
                                        </v-layout>
                                        <v-layout row class="mb-2">
                                            <div
                                                class="font-weight-medium mr-2"
                                            >
                                                Status:
                                            </div>
                                            <div>
                                                {{ request.statusName }}
                                            </div>
                                        </v-layout>
                                        <v-layout row class="mb-2">
                                            <div
                                                class="font-weight-medium mr-2"
                                            >
                                                Category:
                                            </div>
                                            <div>
                                                {{ request.categoryName }}
                                            </div>
                                        </v-layout>

                                        <v-layout row class="mb-2">
                                            <div
                                                class="font-weight-medium mr-2"
                                            >
                                                Request Last Update Time:
                                            </div>
                                            <div>
                                                {{ request.lastUpdatedTime }}
                                            </div>
                                        </v-layout>

                                        <v-divider
                                            class="pt-3 mt-3"
                                        ></v-divider>
                                        <div class=""></div>
                                        <div
                                            class="my-3"
                                            v-html="request.description"
                                        ></div>
                                    </div>
                                </div>
                            </v-card-text>
                        </v-layout>
                    </v-layout>

                    <v-spacer></v-spacer>
                </v-card>
            </v-flex>
            <v-flex xs4>
                <v-card
                    class="pa-3"
                    style="border: 2px solid rgb(76, 175, 80); box-shadow: 5px 5px 2px #c7ced8;"
                >
                    <div v-if="loading" class="">
                        <v-progress-linear
                            :indeterminate="true"
                            color="success"
                        ></v-progress-linear>
                    </div>
                    <div v-if="request">
                        <v-layout row class="mb-2 pt-3">
                            <v-icon
                                class="mr-2 ml-1"
                                dark
                                style="font-size: 50px;"
                                :color="getStatusIconColor()"
                                >{{ getStatusIcon() }}</v-icon
                            >
                            <div class="title pt-3">
                                {{ request.statusName }}
                            </div>
                        </v-layout>
                        <v-divider class="mt-3"></v-divider>
                        <div class="subheading font-weight-light mt-3 mb-1">
                            {{ getAttachmentText() }}
                        </div>
                        <div v-for="attachment in getAttachments()">
                            <v-btn
                                class="mt-2 ml-1 px-3"
                                @click="
                                    downloadAttachment(
                                        `https://utaw.sdpondemand.manageengine.com/app/itdesk/api/v3${
                                            attachment.content_url
                                        }`,
                                    )
                                "
                            >
                                <v-icon color="blue" left dark>mdi-file</v-icon>
                                {{ truncateText(attachment.name) }}
                                <v-icon right>mdi-download</v-icon>
                            </v-btn>
                        </div>
                    </div>
                </v-card>
            </v-flex>
        </v-layout>
    </v-container>
</template>
<script>
import {
    groupBy,
    formatPhoneNumber,
    truncate,
    pluralize,
} from "../../utils/helpers.js";
import moment from "moment";

export default {
    data: () => ({
        request: null,
        processing: false,
        loading: true,

        regID: "",

        pagination: {
            totalCount: 0,
            rowsPerPage: 5,
            page: 1,
        },

        rules: {
            required: (v) => {
                return !!v || "Required";
            },
        },
    }),
    computed: {},
    async created() {
        await this.load();
    },
    methods: {
        async load() {
            await this.loadRequest();
        },
        async loadRequest() {
            const response = await this.$http.get(
                `api/manageengine/getbyID?id=` + this.$route.params.id,
            );

            console.log(this.$route);
            response.description = response.description
                ? response.description.replaceAll(
                      "/app/itdesk/servlet/",
                      "https://utaw.sdpondemand.manageengine.com/app/itdesk/servlet/",
                  )
                : response.description;
            console.log(response);
            this.request = response;
            this.loading = false;
        },
        formatPhoneNumber(number) {
            return formatPhoneNumber(number);
        },
        getStatusIcon() {
            if (!this.request || !this.request.statusName) return;

            switch (this.request.statusName) {
                case "Closed":
                    return "mdi-check-circle";
                case "Open":
                    return "mdi-clock";
                default:
                    return "";
            }
        },
        getStatusIconColor() {
            if (!this.request || !this.request.statusName) return;

            switch (this.request.statusName) {
                case "Closed":
                    return "success";
                case "Open":
                    return "#fdb400";
                default:
                    return "#aeb8bf";
            }
        },
        getAttachmentText() {
            return (
                this.getAttachments().length +
                " " +
                pluralize("Attachment", this.getAttachments().length)
            );
        },
        getAttachments() {
            if (!this.request || !this.request.attachments) return [];
            console.log(JSON.parse(this.request.attachments).length);
            return JSON.parse(this.request.attachments);
        },
        getTechnician() {
            if (!this.request || !this.request.technicianEmail) return "";

            return (
                this.request.technicianName +
                " - " +
                this.request.technicianEmail
            );
        },
        downloadAttachment(attachment) {
            window.location = attachment;
        },
        truncateText(attachment) {
            return truncate(attachment, 50);
        },
    },
};
</script>
<style>
.v-expansion-panel__header {
    height: 63px;
}
.spacail-needs-link {
    color: rgb(76, 175, 80);
    display: inline-block;
    word-wrap: break-word;
    width: 100%;
}
.tip-grid.container {
    padding-left: 0px !important;
    padding-right: 0px !important;
    padding-bottom: 0px !important;
}
.tip-grid .v-card__text {
    padding-top: 4px !important;
}
.tip-grid .flex {
    padding: 0px !important;
    padding-top: 24px !important;
}
.tip-grid .v-card {
    box-shadow: 0 0 0 0 rgba(0, 0, 0, 0.2), 0 0 0 0 rgba(0, 0, 0, 0.14),
        0 0 0 0 rgba(0, 0, 0, 0.12) !important;
}
</style>
